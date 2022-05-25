var fromOld;
var toOld;

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

function changeFrom() {
    const from = $("#demoneda").val();
    const to = $("#amoneda").val();

    if (from == to) { 
        $("#amoneda").val(fromOld);
    }

    console.log(fromOld);
}

function changeTo() {
    const from = $("#demoneda").val();
    const to = $("#amoneda").val();

    if (from == to)
        $("#demoneda").val(toOld);

    console.log(toOld);
}