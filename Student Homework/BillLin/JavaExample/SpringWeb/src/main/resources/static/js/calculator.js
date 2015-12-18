$(function() {
	if(window.console)
		console.log( "ready!" );
	
    $("#_C").click(function () {
        var inputdata = {};
        $.ajax({
            type: 'GET',
            url: 'clear',
            datatype: 'application/json',
            data: inputdata,
            async: false,
            success: function (data) {
                $("#_result").val(data);
                $("#isReset").val("true");
                $("#operator").val("+");
                $("#operand").val("0");
            }
        });
    });
});

function addNumber(number) {
    var currentVal = parseInt($("#_result").val(), 10);
    var isReset = $("#isReset").val();
    if (isReset == "true") {
        currentVal = 0;
    }
    var intVal = parseInt(number, 10);
    currentVal = currentVal * 10 + intVal;
    $("#isReset").val("false");
    $("#_result").val(currentVal);
}

function addOperator(operator) {
    var currentVal = parseInt($("#_result").val(), 10);
    $("#operand").val(currentVal);
    if ($("#operator").val() != "")
        compute();
    $("#operator").val(operator);
    $("#isReset").val("true");
}

function compute() {
    var operand = $("#operand").val();
    var operator = $("#operator").val();
    var inputdata = { operand: operand, operator: operator };
    $.ajax({
        type: 'GET',
        url: 'compute',
        datatype: 'application/json',
        data: inputdata,
        async: false,
        success: function (data) {
        	$("#_result").val(data);
        }
    });
}
