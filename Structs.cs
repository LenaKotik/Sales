// Made by LenaKotik
using System;
using System.ComponentModel;

public struct StatisticsViewModel
{
    [DisplayName("Пользователь")]
    public string UserCode { set; get; }
    [DisplayName("За День")]
    public int Day { set; get; }
    [DisplayName("За Неделю")]
    public int Week { set; get; }
    [DisplayName("За Месяц")]
    public int Month { set; get; }
}
public struct Entry
{
    [DisplayName("Время")]
    public DateTime time { set; get; }
    [DisplayName("Пользователь")]
    public string userCode { set; get; }
    [DisplayName("Модель")]
    public string product { set; get; }
    public override string ToString() =>
        $"Пользователь [{userCode}] распечатал \'{product}\' в {time} по МСК";
}
public struct Costumer
{
    [DisplayName("Имя")]
    public string Name { set; get; }
    [DisplayName("Номер телефон")]
    public string Phone { set; get; }
}
public struct StorageItem
{
    public string Material { set; get; }
    public short Amount { set; get; }
}
public struct Product
{
    public string Device { set; get; }
    public string Vendor { set; get; }
    public string Model { set; get; }
    public string Type { set; get; }
    public string Filepath { set; get; }
    public override string ToString() =>
        $"{Device}/{Vendor}/{Model}/{Type}";
    public Product(string D, string V, string M, string T, string F)
    {
        Device = D;
        Vendor = V;
        Model = M;
        Type = T;
        Filepath = F;
    }
}