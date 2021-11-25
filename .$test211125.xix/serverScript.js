cnt = 0;
xid = setInterval(move, 10);

function move() {
    if (cnt < 1000) {
        cnt++;
        $XT("analog_1").value = cnt;
        console.log(cnt);
    }   else {
    clearInterval(xid);
    }
} 

//move_script
(function() {

})();
