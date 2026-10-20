import type { Episodio } from '../models/Episodio';
import { sinVacios } from '../utils/parseo';
import { GraphQLClient } from './GraphQLClient';
import type { ICrudService, Params } from './ICrudService';

const CAMPOS = 'id serieId noEpisodio titulo calificacion fechaEmision esEspecial';

/** Único lugar que conoce los nombres de queries/mutations de Episodio en el servidor. */
export class EpisodioService implements ICrudService<Episodio> {
  constructor(private readonly gql: GraphQLClient = GraphQLClient.getInstance()) {}

  async adicionar(e: Episodio): Promise<Episodio> {
    const d = await this.gql.request<{ adicionarEpisodio: Episodio }>(
      `mutation($input: EpisodioInput!) { adicionarEpisodio(input: $input) { ${CAMPOS} } }`, { input: e });
    return d.adicionarEpisodio;
  }

  async buscar(p: Params): Promise<Episodio | null> {
    const { serieId, noEpisodio } = sinVacios(p);
    if (!serieId || !noEpisodio) throw new Error('Seleccione la serie e ingrese el número de episodio.');
    const d = await this.gql.request<{ buscarEpisodio: Episodio | null }>(
      `query($serieId: ID!, $noEpisodio: Int!) {
         buscarEpisodio(serieId: $serieId, noEpisodio: $noEpisodio) { ${CAMPOS} } }`,
      { serieId, noEpisodio: Number(noEpisodio) });
    return d.buscarEpisodio;
  }

  async actualizar(e: Episodio): Promise<Episodio> {
    const d = await this.gql.request<{ actualizarEpisodio: Episodio }>(
      `mutation($input: EpisodioInput!) { actualizarEpisodio(input: $input) { ${CAMPOS} } }`, { input: e });
    return d.actualizarEpisodio;
  }

  async eliminar(id: string): Promise<boolean> {
    const d = await this.gql.request<{ eliminarEpisodio: boolean }>(
      `mutation($id: ID!) { eliminarEpisodio(id: $id) }`, { id });
    return d.eliminarEpisodio;
  }

  async listar(filtro: Params): Promise<Episodio[]> {
    const { serieId, titulo } = sinVacios(filtro);
    const d = await this.gql.request<{ listarEpisodios: Episodio[] }>(
      `query($serieId: ID, $titulo: String) {
         listarEpisodios(serieId: $serieId, titulo: $titulo) { ${CAMPOS} } }`, { serieId, titulo });
    return d.listarEpisodios;
  }
}
