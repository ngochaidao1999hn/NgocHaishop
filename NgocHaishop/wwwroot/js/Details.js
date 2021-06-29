function Change_image() {
    var url = '';
    url += $(this).attr('src');
    $("#Pro_Detail_Main_Image").attr('src', url);
}