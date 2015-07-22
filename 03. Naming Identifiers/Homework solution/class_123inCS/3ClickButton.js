function onButtonClick(event, args) {
    var browserWindow = window,
      browserType = browserWindow.navigator.appCodeName,
      isBorwserMozilla = (browserType == "Mozilla");
    if (isBorwserMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}