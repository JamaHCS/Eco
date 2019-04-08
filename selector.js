

$(function() {
  $("#id_categoria").change(function() {
    if ($(this).val() === "3") {
      $("#id_input").prop("disabled", false);
    } else {
      $("#id_input").prop("disabled", true);
    }
  });
});

console.log("Primer selector ok");

$(function() {
  $("#id_categoria_2").change(function() {
    if ($(this).val() === "3") {
      $("#id_input_2").prop("disabled", false);
    } else {
      $("#id_input_2").prop("disabled", true);
    }
  });
});

console.log("Segundo selector ok");
