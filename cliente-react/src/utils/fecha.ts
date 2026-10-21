// Formato input datetime-local
export const paraInput = (iso: string): string => iso.slice(0, 16);

// Formato para mostrar
export const paraMostrar = (iso: string): string => iso.slice(0, 16).replace('T', ' ');
