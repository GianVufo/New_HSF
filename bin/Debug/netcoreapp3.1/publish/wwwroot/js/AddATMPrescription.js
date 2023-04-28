function AddATMPrescription() {

  let properties = {
    Id: $("#atm-prescriptionId").val(),
    PacientName: $("#atm-pacientName").val(),
    DoctorName: $("#atm-doctorName").val(),
    DateOfMedicalAppoiment: $("#atm-dataAppoiment").val(),
  };

  $.post("/AtestadoMedico/ATMPrescription", properties)

    .done(function (output) {
      if (output.id != null) {

        $(location).attr('href', '/AtestadoMedico/ATMCompletePrescription?id=' + output.id);

      } else if (output.stats == "INVALID") {
        $(".alerta").html('<div class="alert alert-danger"> Não foi possível salvar esta receita. Tente novamente mais tarde!</div>');

      }
    })

    .fail(function () {
      alert("Falha ao salvar receita!");
    });
}

$(document).ready(function () {
  $("#atm-receita-form").submit(function (e) {
    e.preventDefault();
    AddATMPrescription();
  });
});