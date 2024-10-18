//﻿$(document).ready(function () {
//    $('#articlesTable').DataTable({
//        dom:
//            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
//            "<'row'<'col-sm-12'tr>>" +
//            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
//        buttons: [
//        ],
//        language: {
//            "sDecimal": ",",
//            "sEmptyTable": "There is no data in the table",
//            "sInfo": "Showing records from _START_ to _END_ from _TOTAL_ record",
//            "sInfoEmpty": "No record",
//            "sInfoFiltered": "(found in _MAX_ record)",
//            "sInfoPostFix": "",
//            "sInfoThousands": ".",
//            "sLengthMenu": "Show _MENU_ record on page",
//            "sLoadingRecords": "Loading...",
//            "sProcessing": "Processing...",
//            "sSearch": "Search:",
//            "sZeroRecords": "No matching records found",
//            "oPaginate": {
//                "sFirst": "First",
//                "sLast": "Last",
//                "sNext": "Next",
//                "sPrevious": "Previous"
//            },
//            "oAria": {
//                "sSortAscending": ": enable ascending column sorting",
//                "sSortDescending": ": enable descending column sorting"
//            },
//            "select": {
//                "rows": {
//                    "_": "%d record selected",
//                    "0": "",
//                    "1": "1 record selected"
//                }
//            }
//        }
//    });
//});

$(document).ready(function () {
    $('#articlesTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
        ],
        language: {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
        }
    });
});