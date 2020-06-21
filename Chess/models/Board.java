package models;

import java.util.ArrayList;
import java.util.List;

public class Board {

    private Tile[][] tiles;

    private List<Move> moves;

    public Board(Tile[][] tiles) {
        this.tiles = tiles;
        this.moves = new ArrayList<>();
    }

    public Tile[][] getTiles() {
        return tiles;
    }

    public List<Move> getMoves() {
        return moves;
    }
}
