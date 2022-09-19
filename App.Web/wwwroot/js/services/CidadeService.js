async function PessoaListaPessoas(nome,idade) {
    return new Promise((resolve, reject) => {
        Get('Pessoa/ListaPessoas?nome'+ nome+ '&idade'+idade).then(function (response) {
            if (response.status === 'success') {
                resolve(response.data);
            } else {
                reject(response.message);
            }
        }, function (err) {
            console.error(err);
            reject('Erro desconhecido');
        });
    });
}

async function PessoaBuscaPorNome(nome) {
    return new Promise((resolve, reject) => {
        Get('Pessoa/BuscaPorNome?nome=' + nome).then(function (response) {
            if (response.status === 'success') {
                resolve(response.data);
            } else {
                reject(response.message);
            }
        }, function (err) {
            console.error(err);
            reject('Erro desconhecido');
        });
    });
}

async function PessoaSalvar(obj) {
    return new Promise((resolve, reject) => {
        Post('Pessoa/Salvar', obj).then(function (response) {
            if (response.status === 'success') {
                resolve(response.data);
            } else {
                reject(response.message);
            }
        }, function (err) {
            console.error(err);
            reject('Erro desconhecido');
        });
    });
}

async function PessoaRemover(id) {
    return new Promise((resolve, reject) => {
        Delete('Pessoa/Remover?id=' + id).then(function (response) {
            if (response.status === 'success') {
                resolve(response.data);
            } else {
                reject(response.message);
            }
        }, function (err) {
            console.error(err);
            reject('Erro desconhecido');
        });
    });
}
