$(document).on('click', "a[name='addtocard']", function () {
    let idrow = $(this).siblings("input[class=getPid]").attr('value');
    //alert(idrow);

    $.ajax({
        url: "/Order/AddtoCart",
        type: "GET",

        data: {
            idP: idrow
        },
        dataType: "JSON",
        contentType: 'application/json;charset=utf-8',
        success: function (data) {
            if (data.code == 666) {
                // alert(data.msg);
                //đổi id trên view cart
                $("a[href='/Order/ViewCart/0']").attr('href', '/Order/ViewCart/' + data.oid + '');
                document.getElementById("numberItems").innerHTML = data.size;

            } else {//chuyen sang login
                location.href = '/Account/Login';
            }

        },
        error: function (error) {
            alert('error');
        }
    })



});



$(document).on('click', "a[name='buynow']", function () {//click buynow
    let idrow = $(this).siblings("input[class=getPid]").attr('value');
    //alert(idrow);

    $.ajax({
        url: "/Order/AddtoCart",
        type: "GET",

        data: {
            idP: idrow
        },
        dataType: "JSON",
        contentType: 'application/json;charset=utf-8',
        success: function (data) {
            if (data.code == 666) {
                // alert(data.msg);
                //đổi id trên view cart
                $("a[href='/Order/ViewCart/0']").attr('href', '/Order/ViewCart/' + data.oid + '');
                document.getElementById("numberItems").innerHTML = data.size;
                location.href = '/Order/ViewCart/' + data.oid + '';
            } else {//chuyen sang login
                location.href = '/Account/Login';
            }

        },
        error: function (error) {
            alert('error');
        }
    })



});