import { type ReactElement, useRef, useState } from 'react';
import { APP_NOMBRE } from '../constants/appInfo';
import type { AnyConfig } from '../entities/EntityConfig';
import { episodioConfig } from '../entities/episodioConfig';
import { serieConfig } from '../entities/serieConfig';
import { MenuBar, type MenuDef } from './MenuBar';
import { WindowFrame } from './WindowFrame';
import { AcercaDeWindow } from './windows/AcercaDeWindow';
import { ActualizarWindow } from './windows/ActualizarWindow';
import { AdicionarWindow } from './windows/AdicionarWindow';
import { BuscarWindow } from './windows/BuscarWindow';
import { EliminarWindow } from './windows/EliminarWindow';
import { ListarWindow } from './windows/ListarWindow';

type Caso = 'Adicionar' | 'Buscar' | 'Listar' | 'Actualizar' | 'Eliminar';

const VENTANAS: Record<Caso, (p: { config: AnyConfig }) => ReactElement> = {
  Adicionar: AdicionarWindow,
  Buscar: BuscarWindow,
  Listar: ListarWindow,
  Actualizar: ActualizarWindow,
  Eliminar: EliminarWindow,
};

const ENTIDADES: AnyConfig[] = [serieConfig, episodioConfig];

interface Abierta {
  clave: string;
  titulo: string;
  x: number;
  y: number;
  z: number;
  contenido: ReactElement;
}

// Ventana principal
export function MainWindow() {
  const [abiertas, setAbiertas] = useState<Abierta[]>([]);
  const zActual = useRef(1);

  function enfocar(clave: string) {
    const z = ++zActual.current;
    setAbiertas((prev) => prev.map((v) => (v.clave === clave ? { ...v, z } : v)));
  }

  function abrir(clave: string, titulo: string, contenido: ReactElement) {
    const z = ++zActual.current;
    setAbiertas((prev) =>
      prev.some((v) => v.clave === clave)
        ? prev.map((v) => (v.clave === clave ? { ...v, z } : v))
        : [...prev, { clave, titulo, contenido, z, x: 30 + prev.length * 28, y: 16 + prev.length * 28 }],
    );
  }

  const cerrar = (clave: string) => setAbiertas((prev) => prev.filter((v) => v.clave !== clave));

  const menus: MenuDef[] = [
    { titulo: 'Archivo', items: [{ texto: 'Cerrar todas las ventanas', accion: () => setAbiertas([]) }] },
    ...ENTIDADES.map((cfg) => ({
      titulo: cfg.nombre,
      items: (Object.keys(VENTANAS) as Caso[]).map((caso) => {
        const Ventana = VENTANAS[caso];
        return {
          texto: caso,
          accion: () => abrir(`${cfg.nombre}-${caso}`, `${caso} ${cfg.nombre}`, <Ventana config={cfg} />),
        };
      }),
    })),
    { titulo: 'Ayuda', items: [{ texto: 'Acerca de...', accion: () => abrir('acerca', 'Acerca de...', <AcercaDeWindow />) }] },
  ];

  return (
    <div className="app">
      <header className="titulo">{APP_NOMBRE}</header>
      <MenuBar menus={menus} />
      <main className="escritorio">
        {abiertas.length === 0 && (
          <div className="bienvenida">
            <div className="logo-card">
              <img src="/aniflex.png" alt="Aniflex" className="logo-bienvenida" />
            </div>
            <p>Use el menú superior para abrir una función.</p>
          </div>
        )}
        {abiertas.map((v) => (
          <WindowFrame key={v.clave} titulo={v.titulo} inicial={{ x: v.x, y: v.y }} z={v.z}
                       onClose={() => cerrar(v.clave)} onFocus={() => enfocar(v.clave)}>
            {v.contenido}
          </WindowFrame>
        ))}
      </main>
    </div>
  );
}
