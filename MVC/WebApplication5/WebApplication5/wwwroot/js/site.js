function sendTodo() {
    let $text = $('#todoNow');
    let $list = $('.todo-list');

    $.ajax({
        type: 'POST',
        url: 'Home/Add',
        data: {
            text: $text.val()
        }
    })
        .done((result) => {
            let $res = $(result);
            $list.append($res);
            $text.val("");
        });
}

function remove(id) {
    $.ajax({
        type: 'POST',
        url: 'Home/Remove',
        data: {
            id: id
        }
    })
        .done((result) => {
            let $item = $("#item_" + id);
            $item.removeClass("shown");
            //$item.html("");
        });
}

$("#todoNow").on('keyup', function (e) {
    if (e.keyCode === 13) {
        sendTodo();
    }
});