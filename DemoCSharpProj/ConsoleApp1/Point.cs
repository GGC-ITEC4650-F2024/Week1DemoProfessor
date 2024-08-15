public class Point {
    public int x;
    public int y;

    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public Point add(Point other) {
        int nx = this.x + other.x;
        int ny = this.y + other.y;
        return new Point(nx, ny);
    }

    public Point sub(Point other) {
        int nx = this.x - other.x;
        int ny = this.y - other.y;
        return new Point(nx, ny);
    }


    public override string ToString()
    {
        return "(" + this.x + ", " + this.y + ")";
    }

}