/** "2024-05-01T20:30:00" -> "2024-05-01T20:30" (formato que exige <input type="datetime-local">). */
export const paraInput = (iso: string): string => iso.slice(0, 16);

/** "2024-05-01T20:30:00" -> "2024-05-01 20:30" (para mostrar en pantalla). */
export const paraMostrar = (iso: string): string => iso.slice(0, 16).replace('T', ' ');
