export class GraphQLClient {
  private static instancia: GraphQLClient;

  private constructor(private readonly url: string) { }

  static getInstance(): GraphQLClient {
    GraphQLClient.instancia ??= new GraphQLClient(import.meta.env.VITE_GRAPHQL_URL ?? '/graphql');
    return GraphQLClient.instancia;
  }

  async request<T>(query: string, variables: Record<string, unknown> = {}): Promise<T> {
    let respuesta: Response;
    try {
      respuesta = await fetch(this.url, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json', Accept: 'application/json' },
        body: JSON.stringify({ query, variables }),
      });
    } catch {
      throw new Error('No se pudo conectar con el servidor. Verifique que esté en ejecución y la dirección configurada.');
    }

    const cuerpo = await respuesta.json().catch(() => null);
    // GraphQL suele responder HTTP 200 aun con errores: hay que mirar el campo "errors".
    if (cuerpo?.errors?.length) throw new Error(cuerpo.errors[0].message);
    if (!respuesta.ok || !cuerpo) throw new Error(`El servidor respondió con error HTTP ${respuesta.status}.`);
    return cuerpo.data as T;
  }
}
