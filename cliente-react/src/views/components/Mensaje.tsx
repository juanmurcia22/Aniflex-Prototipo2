export type Msg = { tipo: 'ok' | 'error'; texto: string };

export function Mensaje({ msg }: { msg: Msg | null }) {
  return msg ? <p className={`mensaje ${msg.tipo}`} role="status">{msg.texto}</p> : null;
}
