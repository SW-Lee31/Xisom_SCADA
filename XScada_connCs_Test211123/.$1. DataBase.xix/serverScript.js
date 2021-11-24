
////////////////////////////////////////////////////////////////////////
// Timer1
////////////////////////////////////////////////////////////////////////
function onTimer1() {

	var now = new Date();
	var a = $XT("SCRIPT.SERVER.ONTIMER_S").value
		if (a == true){
			$XT("SCRIPT.SERVER.Hour").value = ""+now.getHours();
			$XT("SCRIPT.SERVER.Min").value = ""+now.getMinutes();
			$XT("SCRIPT.SERVER.Sec").value = ""+now.getSeconds();
		}
}

////////////////////////////////////////////////////////////////////////
// Timer2
////////////////////////////////////////////////////////////////////////
function onTimer2() {

Date.prototype.format = function(f) {
    if (!this.valueOf()) return " ";
 
    var weekName = ["Sun.", "Mon.", "Tues.", "Wendnes.", "Thurs.", "Fri.", "Satur."];
    var d = this;
     
    return f.replace(/(yyyy|yy|MM|dd|E|hh|mm|ss|a\/p)/gi, function($1) {
        switch ($1) {
            case "yyyy": return d.getFullYear();
            case "yy": return (d.getFullYear() % 1000).zf(2);
            case "MM": return (d.getMonth() + 1).zf(2);
            case "dd": return d.getDate().zf(2);
            case "E": return weekName[d.getDay()];
            case "HH": return d.getHours().zf(2);
            case "hh": return ((h = d.getHours() % 12) ? h : 12).zf(2);
            case "mm": return d.getMinutes().zf(2);
            case "ss": return d.getSeconds().zf(2);
            case "a/p": return d.getHours() < 12 ? "AM" : "PM";
            default: return $1;
        }
    });
};
 
String.prototype.string = function(len){var s = '', i = 0; while (i++ < len) { s += this; } return s;};
String.prototype.zf = function(len){return "0".string(len - this.length) + this;};
Number.prototype.zf = function(len){return this.toString().zf(len);};

var d
d = new Date();
$XT("DB.QUIZ.NOW").value = d.format("yyyy-MM-dd HH:mm:ss");
}

////////////////////////////////////////////////////////////////////////
// Timer3
////////////////////////////////////////////////////////////////////////
function onTimer3() {

var now = new Date();
	var year = now.getFullYear(); 
	var month = now.getMonth() + 1; 
	var day = now.getDate(); 
	var hour = now.getHours(); 
	var minutes = now.getMinutes(); 
	var seconds = now.getSeconds(); 
//$XT("DB.QUIZ.NOW").value = year + "-" + month + "-" + day + " " + hour + ":" + minutes + ":" + seconds
}

////////////////////////////////////////////////////////////////////////
//
////////////////////////////////////////////////////////////////////////



setInterval(onTimer1,1000);
setInterval(onTimer2,1000);
setInterval(onTimer3,1000);

