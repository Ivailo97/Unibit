package models;

import java.util.ArrayList;
import java.util.List;

public class Figure extends Colorful {

    private Tile tile;

    private boolean isDown;

    private FigureType type;

    private List<Tile> attackedTiles;

    private List<Tile> availableTiles;

    public Figure(String color, FigureType type) {
        super(color);
        this.type = type;
        this.attackedTiles = new ArrayList<>();
        this.availableTiles = new ArrayList<>();
    }

    public Tile getTile() {
        return tile;
    }

    public void setTile(Tile tile) {
        this.tile = tile;
    }

    public boolean isDown() {
        return isDown;
    }

    public void setDown(boolean down) {
        isDown = down;
    }

    public FigureType getType() {
        return type;
    }

    public void setType(FigureType type) {
        this.type = type;
    }

    public List<Tile> getAttackedTiles() {
        return attackedTiles;
    }

    public List<Tile> getAvailableTiles() {
        return availableTiles;
    }
}
