
// alert("testing");

// Get element

$(function () {
    $('#sort').change(function () {
        var url = $(this).val();
        if (url != null && url != '') {
            window.location.href = url;
        }
    });
});
