const createProxyMiddleware = require('http-proxy-middleware');
const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:54177';

const context =  [
  "/weatherforecast",
  "/UserData",
  "/PageContents",
  "/Projects",
  "/Skills",
  "/ContactMessages",
];

module.exports = function(app) {
  const appProxy = createProxyMiddleware(context, {
    target: "http://localhost:44481",
    secure: false
  });

  app.use(appProxy);
};
