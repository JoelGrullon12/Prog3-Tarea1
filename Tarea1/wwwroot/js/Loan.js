function changeInteres(){
    const tipoPrestamo = $("#tipoprestamo").val();
    console.log("Tipo de prestamo: "+tipoPrestamo);

    $("#interes").val(tipoPrestamo);
}

//$(document).on('keydown', 'input[pattern]', function (e) {
//    let input = $(this);
//    let oldVar = input.val();
//    let regex = new RegExp(input.attr('pattern'), 'g');

//    setTimeout(function () {
//        let newVal = input.val();
//        if (!regex.test(newVal)) {
//            input.val(oldVar);
//        }
//    }, 1);
//});

function showAll() {
    console.log("Monto: "+$("#monto").val());
    console.log("Tipo de Prestamo: "+$("#tipoprestamo").val());
    console.log("Tasa de Interes: "+$("#interes").val());
    console.log("Cuotas: "+$("#meses").val());
}