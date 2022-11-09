function inicializarTablaGeneral(nombreTabla) {

    $("#" + nombreTabla).DataTable({
        autoWidth: true,
        searching: true,
        paging: true,
        pagingType: "full_numbers",
        lengthMenu: [[10, 15, 20, -1], [10, 15, 20, "Todos"]],
        language: {
            sProcessing: "Procesando...",
            sLengthMenu: "_MENU_ registros por página",
            sZeroRecords: "No existen datos",
            sEmptyTable: "No existen datos",
            sInfo: "Mostrando _END_ de _TOTAL_ registro(s)",
            sInfoEmpty: "Mostrando 0 registros",
            sInfoFiltered: "(Filtrado de un total de _MAX_ registros)",
            sInfoThousands: ",",
            sLoadingRecords: "Cargando...",
            oPaginate: {
                sFirst: "<<",
                sLast: ">>",
                sNext: ">",
                sPrevious: "<"
            },
            oAria: {
                sSortAscending: ": Activar para ordenar la columna de manera ascendente",
                sSortDescending: ": Activar para ordenar la columna de manera descendente"
            }
        }
    });
}

function consultar(url, parametros, div, funcionSuccess, funcionError) {
    $.ajax(
        {
            cache: false,
            async: true,
            type: "GET",
            url: url,
            data: parametros,
            success: function (data, textStatus, jqXHR) {
                $(div).html("");
                $(div).html(data);
            },
            error: function (xhr) {
                
                return false;
            }
        });
}