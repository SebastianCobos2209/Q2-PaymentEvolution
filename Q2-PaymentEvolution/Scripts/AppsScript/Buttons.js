function initializeButtons(){
    $(document).on('click', '.invite-btn', function () {
        const $btn = $(this);
        $btn.toggleClass('active');

        const isDeclined = $btn.hasClass('active');
        $btn.html(
        (isDeclined ? 'Invite Declined' : 'Invite Sent')
        ).css('background-color', isDeclined ? '#ff4444' : '');
    });
}