import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import { MainWindow } from './views/MainWindow';
import './styles.css';

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <MainWindow />
  </StrictMode>,
);
