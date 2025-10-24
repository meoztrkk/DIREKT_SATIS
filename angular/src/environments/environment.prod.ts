import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44317/',
  redirectUri: baseUrl,
  clientId: 'DIREKT_SATIS_App',
  responseType: 'code',
  scope: 'offline_access DIREKT_SATIS',
  requireHttps: true,
  impersonation: {
    userImpersonation: true,
  }
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'DIREKT_SATIS',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44379',
      rootNamespace: 'DIREKT_SATIS',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
