function changeDays() {

    const selectedDay = $("#dia").val();
    let mes = $("#mes").val();

    const dias = [0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
    
    let htmlSelect='';

    for (let i = 1; i <= dias[mes]; i++) {
        htmlSelect += selectedDay == i ? '<option value = "' + i + '" selected> ' + i + '</option > ' : '<option value = "' + i + '" > ' + i + '</option > ';
    }

    /*console.log(htmlSelect);*/
    $("#dia").html(htmlSelect);
}