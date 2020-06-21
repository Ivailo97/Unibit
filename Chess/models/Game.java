package models;

public class Game {

    private boolean won;

    private Board board;

    private long start;

    private long end;

    private long playTime;

    public Game(Board board) {
        this.board = board;
    }

    public void start() {
        this.start = System.currentTimeMillis();
    }

    public void end() {
        this.end = System.currentTimeMillis();
        this.playTime = end - start;
    }



    public boolean isWon() {
        return won;
    }

    public Board getBoard() {
        return board;
    }

    public long getStart() {
        return start;
    }

    public long getEnd() {
        return end;
    }

    public long getPlayTime() {
        return playTime;
    }
}
