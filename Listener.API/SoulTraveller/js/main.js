var main = {
    home: {
        init: function() {
            //var bgc = Math.floor(Math.random() * 11 + 1);
            //$("header").css("background", "url(imgs/bg" + bgc + ".jpg) no-repeat");
            //$("header").css("background-size", "100% auto");
        },
        getContent: function() {
            $.get("http://172.18.5.76:1234/api/home/getpage", {}, function (data) {
                for (var i in data.Data) {
                    var bgc = Math.floor(Math.random() * 11 + 1);
                    var html = '<article><div atitle>' + data.Data[i].Title + '</div><img src="imgs/bg' + bgc + '.jpg"/></article>';
                    $("#container").append(html);
                }
            });
        }
    }
};

main.home.init();
main.home.getContent();

