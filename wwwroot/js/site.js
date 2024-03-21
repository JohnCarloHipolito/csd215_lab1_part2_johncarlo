$(document).ready(function () {
    // Restrict input to valid numbers only using regex
    $(".form-control").on('input', function () {
        this.value = this.value.replace(/[^0-9.]/g, '').replace(/(\..*?)\..*/g, '$1');
    });

    $("#num1, #num2").on('input', function () {
        $("#result").text("");
    });
});
