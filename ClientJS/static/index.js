"use strict";

let _loginForm;
let _mainForm;

let _btnLogin;
let _txtUsername;
let _txtPassword;
let _msg;

let _btnInviaMail;
let _txtTo;
let _txtSubject;
let _txtMessage;

let _tbody;

$(function () {
    _loginForm = $('#loginForm');
    _mainForm = $('#mainForm');

    _btnLogin = $('#btnLogin');
    _txtUsername = $(form1.username);
    _txtPassword = $(form1.password);
    _msg = $('#msg');

    _btnInviaMail = $('#btnInviaMail');
    _txtTo = $('#txtTo');
    _txtSubject = $('#txtSubject');
    _txtMessage = $('#txtMessage');

    _tbody = $('#tbody');

    _loginForm.hide();
    _mainForm.hide();

    richiediMail();

    _btnLogin.on('click', function () {
        let username = _txtUsername.val();
        let password = _txtPassword.val();

        //GESTIONE GRAFICA
        _txtUsername.removeClass('is-invalid');
        _txtUsername.parent().removeClass('alert-danger');
        _txtPassword.removeClass('is-invalid');
        _txtPassword.parent().removeClass('alert-danger');
        _msg.empty();
        if (username == '') {
            _txtUsername.addClass('is-invalid');
            _txtUsername.parent().addClass('alert-danger');
            return;
        }
        else if (password == '') {
            _txtPassword.addClass('is-invalid');
            _txtPassword.parent().addClass('alert-danger');
            return;
        }
        //
        let jsonLogin = {
            "username": username,
            "password": password
        };
        let richiestaLogin = inviaRichiesta('/api/login', 'POST', jsonLogin);
        richiestaLogin.done(function (data) {
            richiediMail();
        });
        richiestaLogin.fail(function (jqXHR, testStatus, strError) {
            if (jqXHR.status == 401) {
                _txtUsername.addClass('is-invalid');
                _txtUsername.parent().addClass('alert-danger');
                _txtPassword.addClass('is-invalid');
                _txtPassword.parent().addClass('alert-danger');
                _msg.html('Credenziali non valide.');
            }
            else
                error(jqXHR, testStatus, strError);
        });
    });

    _btnInviaMail.on('click', function () {
        let to = _txtTo.val();
        let message = _txtMessage.val();
        if (to == '') {
            alert('Inserire il destinatario.');
            return;
        }
        if (message == '') {
            alert('Inserire il messaggio.');
            return;
        }
        let mail = {
            "to": to,
            "subject": _txtSubject.val(),
            "body": message
        };
        let richiestaInvioMail = inviaRichiesta('/api/newMail', 'POST', mail);
        richiestaInvioMail.done(function(data){
            alert(data);    
        });
        richiestaInvioMail.fail(function (jqXHR, testStatus, strError) {
            if (jqXHR.status == 403) {
                alert('Sessione scaduta. Rieffettuare il login per poter inviare la mail.');
                visualizzaLogin();
            }
            else
                error(jqXHR, testStatus, strError);
        });
    });
    $("#btnLogout").on("click",function(){
        //document.cookie="token=;max-age=-1;path=/";   NON FUNZIONANTE PER HTTP-ONLY
        let richiestaLogout=inviaRichiesta("/api/logout", "POST");
        richiestaLogout.done(function(data){
            console.log(data);
            visualizzaLogin()
        });
        richiestaLogout.fail(function (jqXHR, testStatus, strError) {
            if (jqXHR.status == 403)
                visualizzaLogin();
            else
                error(jqXHR, testStatus, strError);
        });
    });
});

function richiediMail() {
    let richiesta = inviaRichiesta('/api/mail', 'GET');
    richiesta.done(function (data) {
        visualizzaMail(data);
    });
    richiesta.fail(function (jqXHR, testStatus, strError) {
        if (jqXHR.status == 403)
            visualizzaLogin();
        else
            error(jqXHR, testStatus, strError);
    });
}

function visualizzaMail(mails) {
    _txtTo.val('');
    _txtSubject.val('');
    _txtMessage.val('');

    _loginForm.hide();
    _mainForm.show();
    mails=mails.reverse();
    console.table(mails);

    _tbody.empty();
    for (let mail of mails) {
        let _tr = $('<tr>').appendTo(_tbody);
        $('<td>').text(mail.from).appendTo(_tr);
        $('<td>').text(mail.subject).appendTo(_tr);
        $('<td>').text(mail.body).appendTo(_tr);
    }
}

function visualizzaLogin() {
    _txtUsername.val('sonny@gmail.com');
    _txtPassword.val('sonny');

    _mainForm.hide();
    _loginForm.show();
}