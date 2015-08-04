//$(".btn-addDocumentoSalida").click(function() {
//    var $cod = $(this).closest("tr")
//        .find(".codigoDocumento")
//        .text();
//    $("#txt-noOficio").val($cod);
//});

$(".btn-addDocumentoSalida").click(function () {
    $("#txt-noOficio").val($(this).attr("data-cod"));
    $('#txt-idDocumentoHidden').val($(this).attr("data-id"));
});

function onBeginFunction() {

}

function OnSuccessFunction(jsonResult) {
    $("#AlertSuccess").html("");
    $("#AlertSuccess").html("<span>" + jsonResult.Message + " </span> <a id='hideAlert' href='#' class='alert-link' style='float:right'>x</a>");
    $("#AlertSuccess").show();
    $("#DocumentoRegistrarNuevo").find('form')[0].reset();
}

function OnFailureFunction() {


}