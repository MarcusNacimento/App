function salvar() {
    let obj = {
        nome: ($("[name='nome']").val() || ''),
        idade: ($("[name='idade']").val() || ''),
        telefone: ($("[name='telefone']").val() || ''),
        endereco: ($("[name='endereco']").val() || ''),
        email: ($("[name='email']").val() || '')

    };
    CidadeSalvar(obj).then(function () {
        window.location.href = '/pessoas';
    }, function (err) {
        alert(err);
});

}