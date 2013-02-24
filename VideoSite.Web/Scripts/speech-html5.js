var Synthesizer = new function () {

	var _synthesizerService = "/Services/Synthesizer.asmx";
	var _tempFolderUrl = "/Temp/";
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
		var data = { text: Synthesizer.getText(), language: Synthesizer.getCulture() };

		$.ajax({
			type: "POST",
			data: JSON.stringify(data),
			url: _synthesizerService + "/SpeakToFile",
			contentType: "application/json; charset=utf-8",
			dataType: "json",
			success: function (response) {
				Synthesizer.playVoice(_tempFolderUrl + filename);
			},
			failure: function (response) {
				alert("Failure: " + response.d);
			}
		});
	}

	this.speakFromStream = function () {
		var text = encodeURI(Synthesizer.getText());
		var language = Synthesizer.getCulture();

		var streamUrl = speakAction + "?text=" + text + "&language=" + language;
		Synthesizer.playVoice(streamUrl);
	}

	this.playVoice = function (audioStream) {
		var audio = new Audio(audioStream);
		audio.play();
	}
}

