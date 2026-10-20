import { defineConfig, loadEnv } from 'vite';
import react from '@vitejs/plugin-react';

// El navegador solo habla con Vite (mismo origen). Vite reenvía /graphql al servidor Java,
// así no hace falta configurar CORS en el servidor durante el desarrollo.
export default defineConfig(({ mode }) => {
  const env = loadEnv(mode, process.cwd(), '');
  return {
    plugins: [react()],
    server: {
      proxy: {
        '/graphql': {
          target: env.VITE_SERVER_URL || 'http://localhost:8080',
          changeOrigin: true,
        },
      },
    },
  };
});
