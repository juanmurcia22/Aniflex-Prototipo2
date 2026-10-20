import { APP_NOMBRE, APP_VERSION, INTEGRANTES } from '../../constants/appInfo';

export function AcercaDeWindow() {
  return (
    <div className="acerca">
      <h3>{APP_NOMBRE}</h3>
      <p><strong>Versión:</strong> {APP_VERSION}</p>
      <p><strong>Desarrollado por:</strong></p>
      <ul>{INTEGRANTES.map((n) => <li key={n}>{n}</li>)}</ul>
    </div>
  );
}
