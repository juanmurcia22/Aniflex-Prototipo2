import { type PointerEvent as ReactPointerEvent, type ReactNode, useState } from 'react';

interface Props {
  titulo: string;
  inicial: { x: number; y: number };
  z: number;
  onClose: () => void;
  onFocus: () => void;
  children: ReactNode;
}

// Ventana arrastrable
export function WindowFrame({ titulo, inicial, z, onClose, onFocus, children }: Props) {
  const [pos, setPos] = useState(inicial);

  function iniciarArrastre(e: ReactPointerEvent) {
    onFocus();
    const dx = e.clientX - pos.x;
    const dy = e.clientY - pos.y;
    const mover = (ev: PointerEvent) => setPos({ x: ev.clientX - dx, y: Math.max(0, ev.clientY - dy) });
    const soltar = () => {
      window.removeEventListener('pointermove', mover);
      window.removeEventListener('pointerup', soltar);
    };
    window.addEventListener('pointermove', mover);
    window.addEventListener('pointerup', soltar);
  }

  return (
    <section className="ventana" style={{ left: pos.x, top: pos.y, zIndex: z }} onPointerDown={onFocus}>
      <header onPointerDown={iniciarArrastre}>
        <span>{titulo}</span>
        <button type="button" aria-label="Cerrar" onPointerDown={(e) => e.stopPropagation()} onClick={onClose}>✕</button>
      </header>
      <div className="contenido">{children}</div>
    </section>
  );
}
