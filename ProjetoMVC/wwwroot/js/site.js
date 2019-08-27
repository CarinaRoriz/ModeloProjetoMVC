// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function funcao() {
    alert("Função JS chamada pela View");
    $.ajax({
        url: "/TesteMvc/FuncaoTeste/",
        type: "post",
        dataType: "json",
        error: function () {
            alert("Erro");
        },
        success: function (data) {
            alert("Dados do modelo recuperados pela requisição realizada na controller");

            $("#txtDescricao").val(data.descricao);
            $("#txtDataHora").val(data.dataHora);

        }
    });
}