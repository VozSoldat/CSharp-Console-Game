using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ConsoleApp1.src.models;

public class TanrayiticDatetime
{
    private TimeOnly time;
    private Day day;
    private Year year;
    private TanrayiticMonth month;

    public int GetYear() => year.Value;
    public int GetMonth() => month.Value;
    public int GetDay() => day.Value;
    public TimeOnly Time => time;


    // ================= CONSTRUCTOR =================
    public TanrayiticDatetime()
    {
        year = new Year(0);
        month = new TanrayiticMonth(1);
        day = new Day(1);
        time = new TimeOnly(08, 00, 00);
    }
    public TanrayiticDatetime(int intYear, int intMonth, int intDay, TimeOnly time)
    {
        year = new Year(intYear - 2024);
        month = new TanrayiticMonth(intMonth);
        day = new Day(intDay);
        this.time = time;
    }
    // ================= END CONSTRUCTOR =================



    public override string ToString()
    {
        string date = $"{year.ToString()}/{month.ToString()}/{day.ToString()}/{time.ToString()}";
        return date;
    }
    // ================= OPERATION =================
    public void AddTime(int hours, int minutes)
    {
        // Tambahkan waktu ke jam dan menit saat ini
        int totalMinutes = time.Minute + minutes;
        var (newMinutes, carryHours) = CarryOver(totalMinutes, 60);

        int totalHours = time.Hour + hours + carryHours;
        var (newHours, carryDays) = CarryOver(totalHours, 24);

        time = new TimeOnly(newHours, newMinutes);

        // Update hari
        int totalDays = day.Value + carryDays;
        var (newDays, carryMonths) = CarryOver(totalDays, 28);
        day.Value = newDays;

        // Update bulan
        int totalMonths = month.Value + carryMonths;
        var (newMonths, carryYears) = CarryOver(totalMonths, 8);
        month.Value = newMonths;

        // Update tahun
        year.Value += carryYears;
    }

    public void AddTime(int hours)
    {
        int totalHours = time.Hour + hours;
        var (newHours, carryDays) = CarryOver(totalHours, 24);

        time = new TimeOnly(newHours, time.Minute);

        // Update hari
        int totalDays = day.Value + carryDays;
        var (newDays, carryMonths) = CarryOver(totalDays, 28);
        day.Value = newDays;

        // Update bulan
        int totalMonths = month.Value + carryMonths;
        var (newMonths, carryYears) = CarryOver(totalMonths, 8);
        month.Value = newMonths;

        // Update tahun
        year.Value += carryYears;
    }

    public void AddDay(int days)
    {
        int totalDays = day.Value + days;
        var (newDays, carryMonths) = CarryOver(totalDays, 28);
        day.Value = newDays;

        int totalMonths = month.Value + carryMonths;
        var (newMonths, carryYears) = CarryOver(totalMonths, 8);
        month.Value = newMonths;

        year.Value += carryYears;
    }

    public void AddMonth(int months)
    {
        int totalMonths = month.Value + months;
        var (newMonths, carryYears) = CarryOver(totalMonths, 8);
        month.Value = newMonths;
        year.Value += carryYears;
    }

    public void AddYear(int years)
    {
        year.Value += years;
    }


    private (int Remainder, int Carry) CarryOver(int value, int maxValue)
    {
        int remainder = value % maxValue; // Nilai yang tetap setelah overflow
        int carry = value / maxValue;    // Nilai overflow yang dibawa ke unit lebih besar
        return (remainder, carry);
    }
    // ================= END OPERATION =================
}
class TanrayiticMonth
{
    int value;
    public int Value { get => value; set => this.value = value; }
    public TanrayiticMonth(int value)
    {
        if (value > 8 || value < 1) throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be between 1 and 8.");
        this.value = value;
    }
    public override string ToString()
    {
        return "" + value;
    }
}

enum TanrayiticMonthName
{
    Colduary = 1,
    Bloomarch = 2,
    Springmay = 3,
    Juniery = 4,
    Redaugust = 5,
    Autumber = 6,
    Falltember = 7,
    Wintember = 8
}

class Year
{
    int value;
    public int Value { get => value; set => this.value = value; }
    readonly int adderConstant = 2024;
    int currentYear
    {
        get
        {
            return value + adderConstant;
        }
    }
    public Year(int value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return "" + currentYear;
    }
}

class Day
{
    private int value;
    public int Value { get => value; set => this.value = value; }

    public Day(int value)
    {
        if (value > 28 || value < 1) throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be between 1 and 28.");
        this.value = value;
    }

    public override string ToString()
    {
        return "" + value;
    }
}