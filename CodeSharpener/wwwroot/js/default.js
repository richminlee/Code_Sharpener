$(document).ready(function () {
    var code = $(".codemirror-textarea")[0];
    var editor = new CodeMirror.fromTextArea(code, {
        theme: "dracula",
        lineNumbers: true,
        mode: "javascript"
    })
});