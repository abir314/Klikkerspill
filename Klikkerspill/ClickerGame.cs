namespace Klikkerspill;

public class ClickerGame
{
    public int Points;
    public int PointsPerClick;
    public int PointsPerClickIncrease;

    public ClickerGame(int points, int pointsPerClick, int pointsPerClickIncrease)
    {
        Points = points;
        PointsPerClick = pointsPerClick;
        PointsPerClickIncrease = pointsPerClickIncrease;
    }

    public void CommandX()
    {
        Environment.Exit(0);
    }

    public void CommandSpace()
    {
        Points += PointsPerClick;
    }

    public void CommandK()
    {
        if (Points < 10) return;
        Points -= 10;
        PointsPerClick += PointsPerClickIncrease;
    }

    public void CommandS()
    {
       if(Points < 100) return;
       Points -= 100;
       PointsPerClickIncrease++;
    }
    
}