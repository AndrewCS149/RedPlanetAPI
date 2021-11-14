function toggleManifestVisiblity() {
    let element = document.getElementById("manifest");

    if (element.style.display === "flex" || element.style.display == "") {
        element.style.display = "none";
    } else {
        element.style.display = "flex";
    }
}