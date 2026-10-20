import { useState } from 'react';

export interface MenuDef {
  titulo: string;
  items: { texto: string; accion: () => void }[];
}

export function MenuBar({ menus }: { menus: MenuDef[] }) {
  const [abierto, setAbierto] = useState<number | null>(null);

  return (
    <nav className="menubar" onMouseLeave={() => setAbierto(null)}>
      {menus.map((m, i) => (
        <div key={m.titulo} className="menu">
          <button type="button" onClick={() => setAbierto(abierto === i ? null : i)}>{m.titulo}</button>
          {abierto === i && (
            <ul>
              {m.items.map((it) => (
                <li key={it.texto}>
                  <button type="button" onClick={() => { setAbierto(null); it.accion(); }}>{it.texto}</button>
                </li>
              ))}
            </ul>
          )}
        </div>
      ))}
    </nav>
  );
}
