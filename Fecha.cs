using System;

public class Fecha
{
    private int dd;
    private int mm;
    private int aa;

    public Fecha()
    { }

    public Fecha(int dd, int mm, int aa)
    {
        this.dd = dd;
        this.mm = mm;
        this.aa = aa;
    }

    public int DD
    {
        get { return this.dd; }
        set { this.dd = value; }
    }

    public int MM
    {
        get { return this.mm; }
        set { this.mm = value; }
    }

    public int AA
    {
        get { return this.aa; }
        set { this.aa = value; }
    }

    private int ProcesarCompararFecha(int dd, int mm, int aa)
    {
        if (this.aa < aa)
        {
            return (-1);
        }

        if (this.aa > aa)
        {
            return (1);
        }

        if (this.mm < mm)
        {
            return (-1);
        }

        if (this.mm > mm)
        {
            return (1);
        }

        if (this.dd < dd)
        {
            return (-1);
        }

        if (this.dd > dd)
        {
            return (1);
        }

        return (0);
    }

    public int CompararFecha(int dd, int mm, int aa)
    {
        return (this.ProcesarCompararFecha(dd, mm, aa));
    }

    public int CompararFecha(Fecha fecha)
    {
        return(this.ProcesarCompararFecha(fecha.dd, fecha.mm, fecha.aa));
    }

    public int ValidarFecha()
    {
        if (this.aa < 0)
        {
            return (-3);
        }

        if ((this.mm < 1) || (this.mm > 12))
        {
            return (-2);
        }

        if (this.dd < 1)
        {
            return (-1);
        }

        switch (this.mm)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                if (this.dd > 31)
                {
                    return (-1);
                }

                break;

            case 4:
            case 6:
            case 9:
            case 11:
                if (this.dd > 30)
                {
                    return (-1);
                }

                break;
            case 2:
                if ((this.aa % 4) != 0)
                {
                    if (this.dd > 28)
                    {
                        return (-1);
                    }

                    break;
                }

                if ((this.aa % 100) == 0)
                {
                    if ((this.aa % 400) != 0)
                    {
                        if (this.dd > 28)
                        {
                            return (-1);
                        }
                    }
                }

                if (this.dd > 29)
                {
                    return (-1);
                }

                break;

            default:
                break;
        }

        return (0);
    }

    public void MostrarFecha()
    {
        Console.WriteLine("Fecha: {0}/{1}/{2}", this.dd, this.mm, this.aa);

        return;
    }
}
