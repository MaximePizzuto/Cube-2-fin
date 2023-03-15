import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PagedonneesComponent } from './pagedonnees.component';

describe('PagedonneesComponent', () => {
  let component: PagedonneesComponent;
  let fixture: ComponentFixture<PagedonneesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PagedonneesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PagedonneesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
