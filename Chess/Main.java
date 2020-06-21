import models.*;

import static models.FigureType.*;

public class Main {

    private static final int TOTAL_FIGURES = 32;
    private static final int BOARD_SIZE = 8;

    private static final String BLACK = "BLACK";

    private static final String WHITE = "WHITE";

    private static final char[] columnLetters = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};

    private static final FigureType[] typesInOrder = {ROOK, KNIGHT, BISHOP, QUEEN, KING, BISHOP, KNIGHT, ROOK};

    private static Figure[] figures;

    private static Tile[][] tiles;

    public static void main(String[] args) {

        initFigures();

        initTiles();

        Board board = new Board(tiles);

        Game game = new Game(board);

        System.out.println();
    }

    private static void initTiles() {
        tiles = new Tile[BOARD_SIZE][BOARD_SIZE];
        for (int i = 0; i < BOARD_SIZE; i++) {
            for (int j = 0; j < BOARD_SIZE; j++) {
                int row = i + 1;
                char col = columnLetters[j];
                Position position = new Position(row, col);
                String color = (j + i) % 2 == 0 ? BLACK : WHITE;
                Tile tile = new Tile(color, position);
                tiles[i][j] = tile;
            }
        }
    }

    private static void initFigures() {

        figures = new Figure[TOTAL_FIGURES];

        for (int i = 0; i < TOTAL_FIGURES / 2; i++) {
            FigureType figureType;
            if (i < BOARD_SIZE) {
                figureType = PAWN;
            } else {
                figureType = typesInOrder[i - BOARD_SIZE];
            }
            figures[i] = new Figure(WHITE, figureType);
        }

        for (int i = TOTAL_FIGURES / 2; i < TOTAL_FIGURES; i++) {
            FigureType figureType;
            if (i < TOTAL_FIGURES - BOARD_SIZE) {
                figureType = PAWN;
            } else {
                figureType = typesInOrder[TOTAL_FIGURES - i - 1];
            }
            figures[i] = new Figure(BLACK, figureType);
        }
    }
}
