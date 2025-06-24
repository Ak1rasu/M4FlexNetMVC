let stages = document.getElementById("stages");

fetch("views/stageview.html")
  .then(response => response.text())
  .then((text) => (
    GetStageJsonData(text)
  ));

  function GetStageJsonData(viewtemplate)
  {
    fetch("/stage") // fetch naar de StageController
    .then(response => response.json()) // verwacht JSON
    .then(json => {
        console.log(json);
        for (let i = 0; i < json.length; i++) {
            stages.innerHTML += CreateHtmlForStage(json[i], viewtemplate);
        }
      
    });
  }

  function CreateHtmlForStage(stage, viewtemplate)
  {
    return viewtemplate
      .replace("#BedrijfsNaam#", stage.BedrijfsNaam)
      .replace("#StageVergoeding#", stage.StageVergoeding)
      .replace("#Stad#", stage.Stad)
      .replace("#Beschrijving#", stage.Beschrijving);
  }