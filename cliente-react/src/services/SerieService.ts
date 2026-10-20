import type { Serie } from '../models/Serie';
import { sinVacios } from '../utils/parseo';
import { GraphQLClient } from './GraphQLClient';
import type { ICrudService, Params } from './ICrudService';

const CAMPOS = 'id titulo temporadas calificacion fechaEstreno enEmision';

/** Único lugar que conoce los nombres de queries/mutations de Serie en el servidor. */
export class SerieService implements ICrudService<Serie> {
  constructor(private readonly gql: GraphQLClient = GraphQLClient.getInstance()) {}

  async adicionar(serie: Serie): Promise<Serie> {
    const d = await this.gql.request<{ adicionarSerie: Serie }>(
      `mutation($input: SerieInput!) { adicionarSerie(input: $input) { ${CAMPOS} } }`, { input: serie });
    return d.adicionarSerie;
  }

  async buscar(p: Params): Promise<Serie | null> {
    const { id, titulo } = sinVacios(p);
    if (!id && !titulo) throw new Error('Ingrese al menos el ID o el título de la serie.');
    const d = await this.gql.request<{ buscarSerie: Serie | null }>(
      `query($id: ID, $titulo: String) { buscarSerie(id: $id, titulo: $titulo) { ${CAMPOS} } }`, { id, titulo });
    return d.buscarSerie;
  }

  async actualizar(serie: Serie): Promise<Serie> {
    const d = await this.gql.request<{ actualizarSerie: Serie }>(
      `mutation($input: SerieInput!) { actualizarSerie(input: $input) { ${CAMPOS} } }`, { input: serie });
    return d.actualizarSerie;
  }

  async eliminar(id: string): Promise<boolean> {
    const d = await this.gql.request<{ eliminarSerie: boolean }>(
      `mutation($id: ID!) { eliminarSerie(id: $id) }`, { id });
    return d.eliminarSerie;
  }

  async listar(filtro: Params): Promise<Serie[]> {
    const { titulo, calificacionMinima } = sinVacios(filtro);
    const d = await this.gql.request<{ listarSeries: Serie[] }>(
      `query($titulo: String, $calificacionMinima: Float) {
         listarSeries(titulo: $titulo, calificacionMinima: $calificacionMinima) { ${CAMPOS} } }`,
      { titulo, calificacionMinima: calificacionMinima === undefined ? undefined : Number(calificacionMinima) });
    return d.listarSeries;
  }
}
