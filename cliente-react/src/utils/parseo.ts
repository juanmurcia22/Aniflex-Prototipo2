// Validaciones de formulario

export function texto(v: string, campo: string): string {
  const t = v.trim();
  if (!t) throw new Error(`El campo "${campo}" es obligatorio.`);
  return t;
}

export function entero(v: string, campo: string, min = 0): number {
  const n = Number(v);
  if (v.trim() === '' || !Number.isInteger(n) || n < min) {
    throw new Error(`El campo "${campo}" debe ser un número entero mayor o igual a ${min}.`);
  }
  return n;
}

export function decimal(v: string, campo: string, min = 0, max = Number.MAX_VALUE): number {
  const n = Number(v);
  if (v.trim() === '' || Number.isNaN(n) || n < min || n > max) {
    throw new Error(`El campo "${campo}" debe ser un número entre ${min} y ${max === Number.MAX_VALUE ? '∞' : max}.`);
  }
  return n;
}

// Formato ISO con segundos
export function fechaHora(v: string, campo: string): string {
  if (!v) throw new Error(`El campo "${campo}" es obligatorio.`);
  return v.length === 16 ? `${v}:00` : v;
}

export function sinVacios(p: Record<string, string>): Record<string, string> {
  return Object.fromEntries(Object.entries(p).filter(([, v]) => v.trim() !== ''));
}

export function mensajeDe(e: unknown): string {
  return e instanceof Error ? e.message : 'Ocurrió un error inesperado.';
}
