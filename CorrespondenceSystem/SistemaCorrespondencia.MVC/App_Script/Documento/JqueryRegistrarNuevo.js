
//$(document).on("click", "#hideAlert", function() {

//    $("#AlertSuccess").hide();

//});


//$(".fecha").datepicker();


function onBeginFunction(parameters)
{

}

function OnSuccessFunction(jsonResult)
{
    $("#AlertSuccess").html("");
    $("#AlertSuccess").html("<span>" + jsonResult.Message + " </span> <a id='hideAlert' href='#' class='alert-link' style='float:right'>x</a>");
    $("#AlertSuccess").show();
    $("#DocumentoRegistrarNuevo").find('form')[0].reset();
}

function OnFailureFunction(jsonResult) {

    
}