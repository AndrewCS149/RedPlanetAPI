function toggleManifestVisiblity() {
    let element = document.getElementById("manifest");
    let button = document.getElementById("toggleManifest");

    if (element.style.display === "flex" || element.style.display == "") {
        element.style.display = "none";
        button.innerHTML = "Show Manfiest";
    } else {
        element.style.display = "flex";
        button.innerHTML = "Hide Manifest";
    }
}