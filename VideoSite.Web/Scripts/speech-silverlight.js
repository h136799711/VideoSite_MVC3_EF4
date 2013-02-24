var silverlightPlugin = null;

function silverlightPluginLoaded(sender, args) {
	silverlightPlugin = sender;
}


function getSilverlightAudioPlayer() {
	if (silverlightPlugin == null) {
		// create control host element
		$("body").prepend(
			$("<div>")
			.attr("id", "silverlightControlHost")
			.css("width", "100px")
			.css("height", "0px")
		);

		// create Silverlight object
		Silverlight.createObject(
			"ClientBin/AudioPlayer.xap",  // source
			silverlightControlHost,  // parent element
			"slPlugin",  // id for generated object element
			{
				width: "100%",
				height: "100%",
				background: "white",
				version: "5.0.61118.0"
			},
			{
				onError: function (sender, args) { alert(args.ErrorMessage); },
				onLoad: silverlightPluginLoaded
			},
			"",
			"context"    // context helper for onLoad handler.
		);
	}

	return silverlightPlugin;
}


var Synthesizer = new function () {

	var _synthesizerService = window.location.href + "Services/Synthesizer.asmx";
	var _tempFolderUrl = window.location.href + "Temp";
	var _culture = "en-US";

	this.getCulture = function () {
		return this._culture;
	}

	this.setCulture = function (lang) {
		this._culture = lang;
	}

	this.getText = function () {
		return $("#inputText").val();
	}

	this.getInstalledVoiceLanguages = function () {
		$.ajax({
			type: "POST",
			data: "{}",
			url: _synthesizerService + "/GetInstalledVoiceLanguages",
			contentType: "application/json; charset=utf-8",
			dataType: "json",
			success: function (response) {
				Synthesizer.displayInstalledVoiceLanguages(response.d);
			},
			failure: function (response) {
				alert("Failure: " + response);
			}
		});
	}

	this.displayInstalledVoiceLanguages = function (data) {
		var langs = new Array(data.length);

		for (var i = 0; i < data.length; i++) {
			langs[i] = {
				text: data[i].Name,
				value: data[i].Code,
				description: data[i].Code,
				imageSrc: "Content/Images/" + data[i].Code + ".png"
			};
		}

		$('#cultureList').ddslick({
			data: langs,
			width: 260,
			selectText: "Language",
			imagePosition: "left",
			onSelected: function (data) {
				Synthesizer.setCulture(data.selectedData.value);
			}
		});
	}

	this.speakFromFile = function () {
		var player = getSilverlightAudioPlayer();
		if (player != null) {
			player.Content.Scripts.PlayFromFile(_synthesizerService, _tempFolderUrl, Synthesizer.getText(), Synthesizer.getCulture());
		}
	}

	this.speakFromStream = function () {
		var player = getSilverlightAudioPlayer();
		if (player != null) {
			player.Content.Scripts.PlayFromStream(speakAction, Synthesizer.getText(), Synthesizer.getCulture());
		}
	}
}

