import { QuickStartTemplatePage } from './app.po';

describe('QuickStart App', function() {
  let page: QuickStartTemplatePage;

  beforeEach(() => {
    page = new QuickStartTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
