$(document).ready(function () {
    load();
});

function load() {
    PessoaListaPessoas('', '').then(function (data) {
        data.forEach(obj => {
            $('#table tbody').append('' +
                '<tr> id= "obj-' + obj.id + '">' +
                '<td>' + (obj.nome || '--') + '</td>' +
                '<td>' + (obj.idade || '--') + '</td>' +
                '<td>' + (obj.telefone || '--') + '</td>' +
                '<td>' + (obj.endereco || '--') + '</td>' +
                '<td>' + (obj.email || '--') + '</td>' +
                '</tr>');

        });
    });

}