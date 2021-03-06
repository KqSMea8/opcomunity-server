﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.Opcomunity
{
    public class AlipayConfig
    {
        public static string APPID = "2018012402055032";
        public static string APP_PRIVATE_KEY = "MIIEogIBAAKCAQEAq4Mcz9KmfetPk6t9Pq1UBnntmEXRjeBgN2wEBjQmuF3KC7mXGjGnFLwyHWum148gzHzHxF6JITCdeOwXqWks/3H4USqmDTyXr3XeZm+4DTL9wwXmRTtaUAGbRB8XKcfRj4gEbgvT72UkEuAbxqYFc4VbdYxqUajNw5GdbwG22rPxoOueIvhT/R1bGXGXlcJHsbmGapm8/i7N1SiwJ9SuMHf9ug3qF1ojr7a1RZyY3Xj0bRp3ydQlhnoV3HPUllHTouS4ZzObd1XVaA3w9MWhGK+AhZTyHjvvoy1/bwa/TFQCYh8rQpUgcWr70KSu73sb/+0s7EcZEEKzpHmfHepemwIDAQABAoIBACI4YsNEcFunW5VHHhInWyB/q1w6cfkwz4G/V341YZRfgjScrv1W8tM8SXN9SyivMggazXDsu8eXf5Pk50Ox7Hx7LORk8gSqFkm35svhdoOLrP4Aa1Vc5kQYTfZljaWUbMeKh/e8/GhDcdMiS+hyr5vA++KURZJNb+CZaSQA3477DIyVoTorG55zPGB3BjItQVcQLC08HTjrvJUOm69W5Tn4mZCXEu8QOA+wUPL1wzw3MKOZAlh09hfeVCDGh17Rm+igLmEgp+VxZQ1eWzpq9pksLs4B4u2dN3R7VdaepLMtIE+YtUSqOqwjDH1+d5q6kOMRJOMb91hEbcags7j0k4ECgYEA2M/Stb5VfyYBgTSLgdyJiel46hUjqNM/W+BH5Q18/Ewisy9RHHZy69KHbAqzGwubL7817Yedu0d8Xvo6CBhdZlACAgwYlnHPQswj2a7kTC/Ej5DgLiwbYygtDGQbWcz2UsBorYC4p670r3yG+WGecVbl8JdT3g4hj5NRCupSrUsCgYEAyoM2jWYyGzYzhi9ieDc8Rlnhylp3rNrN0fNn8cAn1eXxI9Uy/AZ9W7uA38JCaQdONOxaXFbmfMokZnm00rsEvaClph6rA6YyBpzJlHpOUj6dQbr6IYmoKcZca3yKOa+R7ggfzZuns+quM0If9W7O5C/rR4aBKTogZWWvssnx0fECgYAPF5hhUlh9O1YLem7joUhpszjZgpMy41Gbwab/iMrUfTBFLNwGkTA6vjLzEGObVFl/H15PpIsUSEueCOkVOyz1PEiHf/QONOnqim9MbeIyc3jJTZptXGCjrF5GaImG3L+gzwf6W+V+tq0NsitrHKJ83UGwV7hc0rr/VY/kpJ8QtQKBgGGm1/1jFDJO9pVz7/WsHOKHoPskmKS/dZQR3UOTtyHLmXX/7m/c6UH8rm43jDJ9FVcryX7RYJ84Eklf0rPy/pw6BOaPz0MZNvI9VG7Gc1HxY384nDjj2jUas6IZEcYzRRkUzdElh76YIZwR/LsqzZT3DmsVDt9Eai660/hQrMzhAoGAC2AWdKLZvBp/5hWFUtV3OXVUgnim15+TV4nFiWO3bx9VU9fPIU6r6TcglNMMR1rH3Ao3WuoS2Rxeg+fd8p9JnSjZ3l2yjwTIgXFk+gETQP9jdf6+Ge4JWGuzqWW9SbnbrNoKPKHpC4jDyLV84X8dFlJ9yx/xt02REAU/oxGrL48=";
        public static string ALIPAY_PUBLIC_KEY = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEApYh7jQz1rHP7V7d8cEui/lTDtKlflaLcwEAXwAfW3fuonGNtFBI8P4ESMdZDlGmmmtad89INuQmekYiz3lACDZ1hNWPjqdIKvV8hgZTL7WM+ktcIoTqkJs1IVoCMgTTvC6OkP2Y4DIAens9HBua0T75B1BOhENv8CnD2Y9+nbJfl7GRpRlu0aTO3WD0OoNFDHVJLZDj0Knl3SL7wS7M/lCDzM80GZEuTTbm5n0A+K76k/iugb7OoeV8T9QYWVHoHHeID1/JR20nDkRJXkPUi9Fwe0j2MC4PHqemluanug4Qco1c94NVgcFW1U2Wrc7LKu7ZD5fTQX4VsCroIAfvnqwIDAQAB";
        public static string CHARSET = "utf-8";
        public static string ALIPAY_GATEWAY = "https://openapi.alipay.com/gateway.do";
        public static string NOTIFY_URL = "http://order.opcomunity.com/Alipay/TradePayCallBack";
        public static string SELLER_ID = "2088921852479452";
    }
}