$(document).ready(function () {
    // Restrict input to valid numbers only using regex
    $(".form-control").on('input', function () {
        this.value = this.value.replace(/[^0-9.]/g, '').replace(/(\..*?)\..*/g, '$1');
    });

    $("#firstNum, #secondNum").on('input', function () {
        $("#result").text("");
    });
});
