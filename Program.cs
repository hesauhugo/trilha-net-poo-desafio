using DesafioPOO.Models;

var nokia = new Nokia(numero:"99999", modelo:"Nokia9",imei:"0,214125",memoria:16);
nokia.Ligar();
nokia.InstalarAplicativo("Bradesco");


var iphone = new Nokia(numero:"8888888", modelo:"Iphone14",imei:"ah12354das",memoria:64);
iphone.Ligar();
iphone.InstalarAplicativo("Bradesco");

