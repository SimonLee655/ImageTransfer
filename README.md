將html中的base64存為jpeg並將原html含有base64的<img>容器加上一uid，方便取出時，可mapping原jpeg檔，轉回base64回存

因某些原因，以.Net framework 3.5開發

提供兩項功能：
1.將讀入的html檔，搜出html中的img，轉存為jpeg及無img的html後存檔
2.將讀入的無img的html，依1.所產生的tag將jpeg轉base64加到html後存檔

限制：
A.img需包在div中
B.2.所提供的功能讀入的html需是1.轉出的，且該html與jpeg需放在同一資料夾

操作步驟：
html(有base64圖) => html(無base64) + jpeg檔
點1設定路徑，點A選取有圖的html檔案=>按確定後，1設定的資料夾下會產生html與jpeg檔

html(無base64) + jpeg檔 => html(有base64圖)
點2設定路徑，點B選取由上一功能產出之無base64 html檔(與jpeg需在同一資料夾下)，2設定的
資料夾下會產生有base64的html檔