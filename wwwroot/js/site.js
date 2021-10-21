// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var xmlhttp = new XMLHttpRequest(); // open HttpRequest
var url = "https://jsonplaceholder.typicode.com/posts/1/comments";

xmlhttp.onreadystatechange = function () { // check if request is complete
    if (this.readyState == 4 && this.status == 200) {
        var myArr = JSON.parse(this.responseText);
        jsonAPI(myArr);
    }
};
xmlhttp.open("GET", url, true); // open api/json file
xmlhttp.send(); // send it back

function jsonAPI(arr) { // iterate over json data
    var out = "";
    var i;
    for (i = 0; i < arr.length; i++) {
        out += '<div class="item"><a mailto="' + arr[i].email + '">' +
            arr[i].name + '</a></div>';
    }
    document.getElementById("output").innerHTML = out;
}
